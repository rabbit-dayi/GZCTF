﻿using CTFServer.Models.Request.Teams;

namespace CTFServer.Models.Request.Game;

public class ParticipationInfoModel
{
    /// <summary>
    /// 参与队伍
    /// </summary>
    public TeamInfoModel Team { get; set; } = default!;

    /// <summary>
    /// 队伍分值
    /// </summary>
    public int Score { get; set; } = 0;

    /// <summary>
    /// 参与状态
    /// </summary>
    public ParticipationStatus Status { get; set; } = ParticipationStatus.Pending;

    public static ParticipationInfoModel FromParticipation(Participation part)
        => new()
        {
            Team = TeamInfoModel.FromTeam(part.Team),
            Score = part.Score,
            Status = part.Status
        };
}